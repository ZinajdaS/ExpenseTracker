# ExpenseTracker
Automation tests  for Expense Tracker app, written in Selenium WebDriver

There are 4 tests written in C#, with Selenium WebDriver
Tests are: RegisterTest, LoginTest, AddCategoryTest, AddExpenseTest
Page Object Model design pattern is followed
Please run RegisterTest first, than LoginTest, AddCategoryTest, AddExpenseTest
Since user needs to be unique, make sure that in App.config file in the solution for key="user", value is unique
(For example: <add key="user" value="Test" />)
