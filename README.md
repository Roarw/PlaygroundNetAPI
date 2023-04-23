# PlaygroundNetAPI

### NuGet packages:
![image](https://user-images.githubusercontent.com/8555390/233827379-32c602b3-6523-4433-a0b7-bd96d6bb63b1.png)

### Database migration:
If the database migration tool is not installed yet, install it by opening the package manager and running the command:

__dotnet tool install --global dotnet-ef__

It is also a good idea to update the migration tool if it is already installed:

__dotnet tool update --global dotnet-ef__

To check for succesful installation you can run:

__dotnet ef__

To commit a database migration:

__dotnet ef migrations 'ProjectName' add 'CommitName'__

To run a database migration:

__dotnet ef database update__
