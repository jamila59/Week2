
# WordCounter

#### _A C# console application checking the frequency a string appears in another sting. - 12/20/19_

#### _By **Jamila Aliyeva**_

## Description

A C# program where the user is prompted to enter a word and then a sentence. After, they are read back the anount of times their word appears in the sentence they entered. Howeever, if the user enters an invalid input, such as: null, number or empty. The user is given an error msg and asked again to enter their input.

### Specs
| Spec | Input | Output | Description |
| :-------------     | :------------- | :------------- |
| **User inputs one word string** | Input : word | String: "word" | Desc: Prog. gathers word form user| 
| **User inputs sentence** | Input : search for the word "word" | String : "search for the word "word""| Desc: Prog. gathers sentence  from user|
| **User inputs get changed to Upper** | Input: word | Output: "WORD" | Desc: Updating case-sensitivity |
| **Program check for how many times to word appears** | Input: word | Output: the word "word" appears 2 times in the sentence | Desc: Runs a count|
| **Program checks for full word matches only** | Word: "cat" Sentence: "I'm walking to the cathedral."| Output: the word "cat" appears 0 times in the sentence| Desc: Catches prog. error|
| **Program runs an input validation** | Input: null "| Output: Invalid input, try again.| Desc: Catches prog. error|

## Setup/Installation Requirements

1. Open command line and clone this repository to Desktop:
    ```
    $ git clone https://github.com/Jamila59/WordCounter.Solution.git
    ```
2. In command line:
    ```
    $ dotnet build & dotnet run
    ```

## Known Bugs
* No known bugs at this time.

## Technologies Used
* C# / .NET

## Support and contact details

_Please contact Jamila Aliyeva with questions and comments at Aliyeva852@gmail.com ._

### License

*MIT License*

Copyright (c) 2019 **_Jamila Aliyeva_**



