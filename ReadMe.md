# iTunes Data Editor (For Windows)

Latest update: 2023-03-30

The iTunes Data Editor is a tool to access your local iTunes library and edit basic track data (including the "PlayedCount" value).

## Pre-Requisites
It is important to download and install iTunes from apple.com/itunes (using the iTunes64Setup.exe installer). The iTunes Data Editor does NOT work with the iTunes app from the Microsoft Store.

## Quick Start

1. Backup your "iTunes Library.itl" file.
2. Start iTunes.
3. Create a playlist with the tracks you want to edit.
4. Close iTunes.
5. Start the iTunes Data Editor.
6. Select the playlist.
7. Press the "Go" button.
8. Find the track you want to edit.
9. Double-click the value you want to edit.
10. Edit the value.
11. Press "Enter".

## Troubleshooting
- Close iTunes before starting the iTunes Data Editor (it will re-open iTunes automatically, don't worry).
- If the "iTunesLib.iTunesApp" object cannot be created, try configuring iTunes to run as the interactive user.
    - Close iTunes.
    - Open "Component Services" > "Computers" > "My Computer" > "DCOM Config"
    - Right click "iTunes" and click "Properties"
    - Open "Identity" and select "The interactive user."
    - Restart iTunes.

## References
- iTunes COM Interface Documentation @ www.joshkunz.com/iTunesControl/

## License

The iTunes Data Editor was written by César Daniel Mendoza Del Pino. This work is licensed under the Creative Commons Attribution 4.0 International License. To view a copy of this license, visit http://creativecommons.org/licenses/by/4.0/.

## Release Notes

### 2023-03-30 ( v1.0.1 )

- Added "Pre-Requisites", "Troubleshooting" and "References" to the "ReadMe.md" file.
- Updated the .NET framework.

### 2018-05-19 ( v1.0.0 )

- Initial release.