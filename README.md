# MarsRobotProblem


1. Interpreter Pattern:
	The system follows the interpreter design pattern to interpret the input string and create sequnce of command objects based on it, to be executed by robot. 

	The interpreter class implements the interpreter interface containing interpret method.

2. Command Pattern:
    The system follows the command pattern where there is a class of each command and the logical intructions are added to this class.

	The command classes implement the command interface which has the execute command method.
   
3. Factory Methods:
	Special methods are used to get the objects of the data, which also include Command Interpreter as it creates and return objects of command.

4. Singleton Class:
	Singleton class is used for the navigator class.


5. Navigator class takes robot object and string input.
The navigate method invokes the interepreter for each character command, and then creates a sequence of command objects.
These command objects executes the actual instructions. 


6. Abstraction is achieved by implementing interfaces and using them for refernce of child objects.




