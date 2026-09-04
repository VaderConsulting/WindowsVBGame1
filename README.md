# WindowsVBGame1

Visual Studio 2008 VB.NET WinForms host that starts a stock XNA 3.1 Game1 on Button1. `Form1` (284×264) has a single unlabeled `Button1`; click constructs `WindowsGame1.Game1` and calls `Run()`, which clears to CornflowerBlue and exits when GamePad Back is pressed. The project was renamed from `WindowsGame1` to `WindowsVBGame1` (`RootNamespace` is still `WindowsGame1`; leftover `WindowsGame1.exe` sits beside `WindowsVBGame1.exe` in `bin\Debug`). There is no `Content` folder despite `Content.RootDirectory = "Content"`, and the assembly still carries Visual Studio template defaults (`AssemblyCompany` Microsoft, copyright 2009, version 1.0.0.0).

**Source last updated:** 2009-07-12 · **Language:** VB.NET · **Target:** .NET Framework 3.5 (VS 2008 / ProductVersion 9.0.30729) + XNA Framework 3.1 · **Output:** WinForms exe (`WindowsVBGame1`) that hosts an XNA `Game`

## Solution structure

| Project | Language | Type | Purpose |
|---------|----------|------|---------|
| `WindowsVBGame1` (`WindowsVBGame1/WindowsVBGame1.vbproj`) | VB.NET | WinForms exe (`WinExe`, net35) hosting XNA 3.1 `Game` | `Form1` + `Button1` constructs `WindowsGame1.Game1` and calls `Run()` (stock cornflower-blue template). |

## How to open

Open `WindowsVBGame1.sln` in Visual Studio 2008 or later (solution format 10.00) with XNA Game Studio 3.1 installed. The project references `Microsoft.Xna.Framework` and `Microsoft.Xna.Framework.Game` version 3.1.0.0 and targets .NET Framework 3.5.

## Requirements

- Visual Studio 2008, .NET Framework 3.5

## Attribution and provenance

Working copy from Dave Robinson's OneDrive Historical Dev folder `WindowsVBGame1`. Visual Studio template defaults: `AssemblyTitle` / `AssemblyProduct` WindowsGame1, `AssemblyCompany` Microsoft, `AssemblyCopyright` Copyright © Microsoft 2009, `AssemblyVersion` 1.0.0.0. `RootNamespace` is `WindowsGame1`; `AssemblyName` is `WindowsVBGame1`. Startup object is `WindowsGame1.My.MyApplication` with main form `Form1`. Build artifacts show it began as a Temporary Projects `WindowsGame1` and was later saved as `WindowsVBGame1`.

## License

MIT © 2026 VaderConsulting. See `LICENSE`.
