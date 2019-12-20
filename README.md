
# WordCounter

#### _A C# console application checking the frequency a string appears in another sting. - 12/20/19_

#### _By **Jamila Aliyeva**_

## Description

A C# program where the user is prompted to enter a word and then a sentence. After, they are read back the anount of times their word appears in the sentence they entered. Howeever, if the user enters an invalid input, such as: null, number or empty. The user is given an error msg and asked again to enter their input.

### Specs
| Spec | Input | Output | Description |
| :-------------     | :------------- | :------------- |:------------- |
| **User inputs one word string** | **Input:**  word | **String:** "word" | **Desc:** Gathers word form user| 
| **User inputs sentence** | **Input:** search for the word "word" | **String:** "search for the word "word""| **Desc:** Gathers sentence  from user|
| **User inputs get changed to Upper** | **Input:** word | Output: "WORD" | **Desc:** Updating case-sensitivity |
| **Program check for how many times to word appears** | **Input:** word | **Output:** the word "word" appears 2 times in the sentence | **Desc:** Runs a count|
| **Program checks for full word matches only** | **Word:** "Cat" **Sentence:** " I'm walking to the cathedral"| **Output:** The word "cat" appears 0 times in the sentence| **Desc:** Catches error|
| **Program runs an input validation** | **Input:** Null | **Output:** Invalid input, try again| **Desc:** Catches error|

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

### MIT License
Copyright (c) 2019 Jamila Aliyeva

*Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.*


Copyright (c) 2016 **_Jamila Aliyeva_**


