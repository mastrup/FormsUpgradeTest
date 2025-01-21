# FormsUpgradeTest
Project to test the upgrade of custom Field Types in Umbraco forms.

1. Start the project from the `main` branch and sign in to the backoffice with `admin@example.com` / `1234567890`
2. Create a form in Umbraco and add the custom field type `Country DropdownList` - Make sure to add a value to the field setting `Label`.
3. Stop the project and switch to the `v13` branch.
4. Start the project once again and locate the form in the backoffice. Observe how the value in the `Label` field isn't showing.