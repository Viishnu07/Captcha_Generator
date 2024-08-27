
# CAPTCHA Generator

## Overview

The CAPTCHA Generator is a Windows Forms application developed in VB.NET. This application generates CAPTCHA images that can be used to prevent automated bots from submitting forms or accessing restricted areas of an application. The CAPTCHA can be refreshed, played as sound, and verified based on user input.

## Features

- **CAPTCHA Generation**: Creates a CAPTCHA using random characters including uppercase and lowercase letters as well as numbers.
- **CAPTCHA Refresh**: Allows users to generate a new CAPTCHA.
- **CAPTCHA Sound Playback**: Enables users to hear the CAPTCHA text, assisting visually impaired users.
- **CAPTCHA Verification**: Verifies user input against the generated CAPTCHA.

## Project Setup

### Prerequisites

- Visual Studio with VB.NET support

### Installation

1. **Clone the repository:**
   ```bash
   git clone https://github.com/Viishnu07/CAPTCHA-Generator.git
   ```
2. **Navigate to the project directory:**
   ```bash
   cd CAPTCHA-Generator
   ```
3. **Open the solution in Visual Studio:**
   - Open the `CAPTCHA-Generator.sln` file.
4. **Restore NuGet packages:**
   - In Visual Studio, go to `Tools` > `NuGet Package Manager` > `Package Manager Console` and run:
   ```bash
   Update-Package -reinstall
   ```
5. **Build the solution:**
   - Press `Ctrl + Shift + B` or select `Build` > `Build Solution` from the menu.

## Usage

To run the CAPTCHA Generator:

1. **Launch the application:**
   - Press `F5` or select `Debug` > `Start Debugging` in Visual Studio.
2. **Interacting with the CAPTCHA:**
   - **Refresh the CAPTCHA**: Click the "Refresh" button to generate a new CAPTCHA.
   - **Listen to the CAPTCHA**: Click the "Sound" button to hear the CAPTCHA characters spoken aloud.
   - **Verify the CAPTCHA**: Enter the characters shown in the CAPTCHA into the input field and click "Verify" to check if the input matches the CAPTCHA.

### Key Functions

- **`frmCaptcha_Load`**: Initializes the CAPTCHA with random characters and sets the CAPTCHA length.
- **`btnRefresh_Click`**: Refreshes the CAPTCHA to generate new characters.
- **`btnSound_Click`**: Converts the CAPTCHA text to speech, allowing users to hear the CAPTCHA.
- **`btnVerify_Click`**: Verifies the user input against the CAPTCHA text.

## Contributing

Contributions are welcome! To contribute:

1. Fork the repository.
2. Create a new branch (`git checkout -b feature-branch`).
3. Make your changes.
4. Commit your changes (`git commit -m 'Add some feature'`).
5. Push to the branch (`git push origin feature-branch`).
6. Open a Pull Request.

## License

This project is licensed under the MIT License.

## Contact

For any questions or feedback, please reach out at viishnu_sreeganesh@yahoo.com
