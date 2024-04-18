# giwu

## Add a New Migration:
After making changes to your model, you need to add a new migration to capture these changes. Run the following command:
dotnet ef migrations add NewMigrationName --startup-project ..\Admin

## Apply the Migration:
To apply the migration and update your database schema, run the following command:
dotnet ef database update --startup-project ..\Admin
