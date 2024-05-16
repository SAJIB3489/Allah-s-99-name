# Problem Solving in C#

![Demo](https://3447149067-files.gitbook.io/~/files/v0/b/gitbook-legacy-files/o/spaces%2F-MdynmZrfNEt1WSSrlHq%2Favatar-1625630560303.png?generation=1625630560729226&alt=media)


# Allah's 99 Names

This program prints the 99 names of Allah, along with their meanings, one by one on the console. It's a simple C# program designed for problem-solving purposes.

## Demo

![Demo](demo.gif)

## How to Use

1. **Installation**: Before running the program, ensure that you have the `mono-csharp-shell` package installed. You can install it using the following command:

    ```bash
    sudo apt install mono-csharp-shell
    ```

2. **Compiling**: Once you have `mono-csharp-shell` installed, you can compile and run the program using the following command:

    ```bash
    csharp Allah\'s_99names.cs
    ```

    This command will compile the C# code and execute it.

3. **Running**: After compiling, you can run the program. It will display the names of Allah one by one as you press the space bar.

## Code Explanation

The code is written in C# and consists of a single class `Program`. Here's a brief explanation of its structure:

- The `print` method is responsible for printing a string character by character with a delay of 100 milliseconds between each character.
- The `Main` method contains the main logic of the program. It initializes an array containing the 99 names of Allah along with their meanings. Then, it waits for the user to press the space bar and prints each name one by one until all names are printed.

## License

This program is provided under the [MIT License](LICENSE).
