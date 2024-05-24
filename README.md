# English Learning Program

Welcome to the English Learning Program! This application is designed to help users improve their English vocabulary through interactive flashcards and quizzes.

## Features

- *Flashcards*: Review and memorize new words using flashcards.
- *Quizzes*: Test your knowledge with customizable quizzes.
- *Progress Tracking*: Track your learning progress and see how many words you have mastered.
- *Word Database*: Maintain a database of known and unknown words.
- *User Authentication*: Secure user login and profile management.



### Prerequisites

- .NET Framework 4.7.2 or higher
- SQL Server

### Steps

1. Clone the repository:
   bash
   git clone https://github.com/yourusername/english-learning-program.git
   
2. Open the solution in Visual Studio:
   bash
   cd english-learning-program
   start english-learning-program.sln
   
3. Set up the SQL Server database:

   - Create a new database in SQL Server.
   - Run the SQL scripts provided in the DatabaseScripts folder to create the necessary tables.

4. Update the connection string:

   - In Visual Studio, open the App.config file.
   - Update the connection string with your SQL Server database details.

   xml
   <connectionStrings>
       <add name="EnglishLearningDB" connectionString="Data Source=your_server;Initial Catalog=your_database;Integrated Security=True" providerName="System.Data.SqlClient" />
   </connectionStrings>
   

5. Build and run the application.

## Usage

### Flashcards

1. Open the application and log in.
2. Navigate to the Learn section.
3. Use the Next and Previous buttons to navigate through the flashcards.
4. Click Flip to see the meaning.

### Quizzes

1. Navigate to the Quiz section.
2. Start the quiz and select the correct meanings for the displayed words.
3. Your results will be displayed at the end of the quiz.

### Settings
1. Reset your password.
2. Change the number of questions you wanna solve.


## Contributing

Contributions are welcome! Please fork the repository and create a pull request with your changes. Make sure to follow the project's coding standards and include appropriate tests.

### Reporting Issues

If you encounter any issues or bugs, please report them using the [GitHub Issues](https://github.com/yourusername/english-learning-program/issues) page.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for more details.

## Contact

For any questions or suggestions, feel free to reach out to the project maintainer at your-email@example.com.

---

Happy Learning!
