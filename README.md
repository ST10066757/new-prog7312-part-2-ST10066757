# Municipal Services Application

## Overview
This application allows citizens to report municipal issues such as sanitation problems, road issues, and utility concerns. The application is designed to be user-friendly and encourages active participation through a simple and intuitive interface.

## How to Use
1. On startup, the main menu will present three options. Currently, only "Report Issues" is functional.
2. Click on "Report Issues" to navigate to the reporting form.
3. Fill in the required details, attach any relevant files, and submit your issue.
4. You can return to the main menu using the `X` that appears when you open the Report Issues Form, this will close the child form and reopen the main menu form.
5. To exit the application click on the `Exit` button on the bottom of the side navigation bar.

## Version Number: 1.0

Municipal Services App version 1.0 is the initial release of the windows forms application.

## Minimum Hardware Specifications Required:

To run the Municipal Services App smoothly, ensure your system meets the following minimum hardware specifications:
- Processor: Intel Core i3 or equivalent
- RAM: 4GB
- Storage: 100MB available disk space
- Display: 1366x768 resolution or higher

## How to download Visual Studio:

You can download Visual Studio from the official Microsoft website. Follow these steps:
1. Visit the [Visual Studio Download Page](https://visualstudio.microsoft.com/downloads/).
2. Choose the edition of Visual Studio that best suits your needs (Community, Professional, or Enterprise).
3. Click on the "Download" button to start the download.
4. Follow the on-screen instructions to complete the installation process.

## How to install and run this program on Visual Studio:

To install and run the Municipal Services App on Visual Studio, follow these steps:
1. Clone or download the Municipal Services App repository from [GitHub link].
2. Open Visual Studio and select "Open a project or solution" from the start window.
3. Navigate to the directory where you saved the cloned or downloaded repository and select the solution file (usually named "MunicipalServiceApp.sln").
4. Build the solution using the `Build` menu.
5. Run the application using `Start` or `Ctrl + F5`.
6. Visual Studio will launch the application in a windows form.

## FAQs:

**Q: *How do I submit an issue?*
A: Click the Report Issues button in the main menu, fill in all the fields on the page, you can track your progress with the progress bar, once all the fields have been filled in you can click submit.

**Q: *Why are the other buttons not working?*
A: The other buttons are not working as they are still being implemented and will be active once the functionality has been added.

**Q: *How do I exit the application?*
A: Click the Exit button in the side navigation bar to exit the application.

**Q: *Why am I receiving notifications?*
A: If the app is open and you are inactive for 10 minutes you will start receiving notifications every 10 minutes to encourage you to use the app.


## Code Attribution
- for the layout: https://www.youtube.com/watch?v=BtOEztT1
- Co-Pilot for the logo
- for the notifications: https://learn.microsoft.com/en-us/windows/apps/design/shell/tiles-and-notifications/send-local-toast?tabs=uwp

## Developer Information
- Developed By Raven Weeks
- Student Number: ST10066757
- Contact: ST10066757@vcconnect.edu.za

## Link to Github Repository
https://github.com/VCWVL/prog7312-part-1-ST10066757.git

## Workflows
1. .NET Framework Continuous Integration (CI) Workflow
This workflow is triggered on every push or pull request to the main branch. It ensures that the codebase is always in a buildable state and produces a release build of the project.

2. Code Quality Check Workflow
This workflow runs static code analysis checks on every push or pull request to the main branch to ensure the code adheres to established coding standards and guidelines.

## Push Notifications
- Push notifications have been setup but only send notifications if the user has the application open after 10 minutes of inactivity.


