using iTunesLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDE.iTunesDataEditor
{
    public partial class MainForm : Form
    {
        private iTunesApp iTunes;
        private IITPlaylist selectedPlaylist;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Start iTunes.
            if (iTunes == null)
            {
                iTunes = new iTunesLib.iTunesApp();
            }

            // Populate the playlist selector.
            foreach (IITPlaylist playlist in iTunes.LibrarySource.Playlists)
            {
                PlaylistComboBox.Items.Add(playlist.Name);
            }

            // Select the first item.
            PlaylistComboBox.SelectedIndex = 0;
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            if (PlaylistComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a playlist.", "Error", MessageBoxButtons.OK);
                return;
            }
            else
            {
                // Look for the selected playlist.
                foreach (IITPlaylist playlist in iTunes.LibrarySource.Playlists)
                {
                    if (playlist.Name == PlaylistComboBox.SelectedItem.ToString())
                    {
                        selectedPlaylist = playlist;
                        break;
                    }
                }
            }

            // Warn about playlists with more than 1000 tracks.
            if (selectedPlaylist.Tracks.Count > 1000)
            {
                if (MessageBox.Show("The selected playlist has " + selectedPlaylist.Tracks.Count + " tracks. Do you want to continue?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
            }

            // Get the tracks and populate the grid-view.
            MainDataGridView.DataSource = GetTracks(selectedPlaylist);

            // Useful code example: How to get the main library.
            // IITLibraryPlaylist mainLibrary = iTunes.LibraryPlaylist;
            // selectedPlaylist = (IITPlaylist)mainLibrary;
        }

        private DataTable GetTracks(IITPlaylist playlist)
        {
            // Create the "Track" table.
            DataTable trackTable = new DataTable("Track");
            trackTable.Columns.Add("TrackDatabaseID", typeof(int));
            trackTable.Columns.Add("Name", typeof(String));
            trackTable.Columns.Add("Artist", typeof(String));
            trackTable.Columns.Add("Album", typeof(String));
            trackTable.Columns.Add("Genre", typeof(String));
            trackTable.Columns.Add("PlayedCount", typeof(int));

            // Populate the "Track" table.
            IITTrackCollection tracks = playlist.Tracks;
            foreach (IITTrack track in tracks)
            {
                DataRow trackRow = trackTable.NewRow();

                trackRow["TrackDatabaseID"] = track.TrackDatabaseID;
                trackRow["Name"] = track.Name;
                trackRow["Artist"] = track.Artist;
                trackRow["Album"] = track.Album;
                trackRow["Genre"] = track.Genre;
                trackRow["PlayedCount"] = track.PlayedCount;

                trackTable.Rows.Add(trackRow);
            }

            return trackTable;
        }

        private void MainDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            // Hide the track id column.
            this.MainDataGridView.Columns["TrackDatabaseID"].Visible = false;
        }

        private void MainDataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            // Remember the original value.
            MainDataGridView.CurrentCell.Tag = MainDataGridView.CurrentCell.Value;
        }

        private void MainDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Compare against the original value.
            object oldValue = MainDataGridView.CurrentCell.Tag;
            object newValue = MainDataGridView.CurrentCell.Value;
            if (newValue != oldValue) 
            {
                // Get the id of the current track.
                // This is a runtime ID, it is only valid while the current instance of iTunes is running.
                int trackDatabaseId = (int)MainDataGridView.CurrentRow.Cells["TrackDatabaseID"].Value;

                // Look for the selected track.
                foreach (IITTrack track in selectedPlaylist.Tracks)
                {
                    if (track.TrackDatabaseID == trackDatabaseId)
                    {
                        // Set the new value.
                        switch (MainDataGridView.Columns[MainDataGridView.CurrentCell.ColumnIndex].Name)
                        {
                            case "Name": track.Name = newValue.ToString(); break;
                            case "Artist": track.Artist = newValue.ToString(); break;
                            case "Album": track.Album = newValue.ToString(); break;
                            case "Genre": track.Genre = newValue.ToString(); break;
                            case "PlayedCount": track.PlayedCount = (int)newValue; break;
                            default:
                                break;
                        }
                    }
                }
            }
        }
    }
}
