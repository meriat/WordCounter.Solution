# Word Counter

## Description

A program that checks how frequently a word appears in a given string. The user should input both the word and a list of words to check. Check for full word matches only.


## Behavior-driven Development

| Specs    |  Input | Expected Output    
| ------------- |------------- |:-------------:|
| Check to see if input word and list is empty. |Input!: "" & list: ""| false
| Check to see if input word and list element are not same. |Input!: "hello" & list: "hi"| false
| Check to see if input word and list element are same. |Input!: "hello" & list: "hello"| true
| Check to see if word matched any list element. Counter value is number of matches.| input1: "hello" & list: "this is hello world" | 1


## Setup/Installation Requirements

1. Clone this repository by using Terminal command:
```
    $ git clone https://github.com/meriat/Word-Counter.Solution.git
```
2. Change into the work directory using Terminal command:
```
    $ cd WordCounter.Solution
```
3. Open the project in your preferred text editor.


## Known Bugs

None known in this version.

## Support and contact details

Please contact us at josemeria93@gmail.com for more information and/or feedback.

## Technologies Used

* Visual Studio Code
* C# FixFormat 0.0.71
* C#/.Net Core 1.1
* Mono
* Git
* GitHub

### License: MIT.

#### Copyright (c) 2018 Meria Thomas