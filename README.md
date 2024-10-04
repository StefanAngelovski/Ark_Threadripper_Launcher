# Ark Threadripper Launcher

![Title](https://res.cloudinary.com/dk2fdiuvb/image/upload/v1717156462/cards/hksnbcces87fd8lpbsxv.png)
*This image showcases the color themes available in the launcher.*

![Launcher](https://github.com/user-attachments/assets/3ff9ff1d-05cb-42ba-ba26-98d7e0f93621)
*This GIF demonstrates the core functionality of the launcher.*

![Launcher2](https://github.com/user-attachments/assets/4b36398f-0c34-4f99-ac71-d5b71276ace1)
*This GIF shows the automatic updating system in action.*

---

**Ark Threadripper Launcher** is a WPF application built using .NET C# in **Visual Studio**. It provides a custom interface for connecting to the Ark: Threadripper server cluster for **Ark: Survival Evolved** and **Ark: Survival Ascended**. The launcher integrates **MahApps Metro** to deliver a sleek, modern UI with customizable color themes.

### Features

- **Direct Connection**: Allows users to connect directly to the [Ark: Threadripper](https://survivetheark.com/index.php?/forums/topic/273566-au-threadripper-server-cluster-9x-all-maps-community-support-dedicated-tr4/) servers using Steam.
- **Discord Integration**: Displays online users and those in voice chat within the Discord server.
- **Customizable Themes**: Users can change the bezel and button colors to their liking.
- **Game Optimization**: Includes cache clearing and easy access to the screenshots folder.
- **Game News**: View the latest game news directly within the launcher.

### Automatic and Manual Updates

The launcher has a built-in updating system that checks for updates and new versions hosted on Dropbox. The app can be set to update automatically or manually. It also includes **patch notes** to display new features and bug fixes for each update.

### How the Launcher Connects to Servers

The launcher connects to the game servers via the Steam server system, using commands like:

```plaintext
steam://run/346110//+connect%20ark.yukitsuki.com:27016
