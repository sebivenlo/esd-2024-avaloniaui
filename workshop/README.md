Folders you're going to use for the workshop:<br/><br/>
<b>CharactorCreatorCrossPlatform:</b> Directory that contains the models, views and viewmodels. Use this to make changes to the code.<br/><br/>
<b>CharactorCreatorCrossPlatform.Browser:</b> Avalonia UI build which runs via the browser. Use this to run your CharacterCreator from the dev container terminal.<br/><br/>

How to open and run the project:
| Step | Description |
|---|---|
|1. | Open VScode. |
|2. | Hover over <b>"File"</b> and select <b>"Open Folder"</b>. Or simply click on <b>"Open Folder"</b> if you have a new window in VScode. |
|3. | Select <b>"CharacterCreatorCrossPlatform"</b>, under the folder <b>"workshop"</b>. |
|4. | Once upon opening, Dev Containers will ask to Reopen the project in a dev container. Click on </b>"Reopen in Container"</b>. |
|5. | Simply wait until the dev containers is finished creating the container. It is finished when it says <b>"Done. Press any key to continue."</b>. You should now have a docker container that uses a <b>"vsc"</b> image.|
|6. | Open a new terminal in VScode. |
|7. | Navigate to <b>"CharacterCreatorCrossPlatform/CharacterCreatorCrossPlatfom"</b> in your VScode terminal. |
|8. | Execute <b>"dotnet build"</b>. |
|9. | Now navigate to <b>"CharacterCreatorCrossPlatform/CharacterCreatorCrossPlatform.Browser"</b> in your VScode terminal. |
|10. | Repeat step 8. |
|11. | Execute <b>"dotnet run"</b>.|
|12. | It should now run the project via the localhost that VScode generated in your terminal. |

In case of failures, we recommend to update your VScode to the latest version. If this still doesn't work, ask us.

Other useful commands:
- dotnet clean: Clean the project build to remove old build files.
- dotnet restore: Restore all the .NET packages. 
