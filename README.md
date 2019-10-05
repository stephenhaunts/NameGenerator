# Name Generator

Name Generator is a simple library to generate readable names for people. This library works by creating human-readable names by alternating between vowels and consonants.

## Example Usage

```csharp
string nameOne = Name.Create(5);
```
The number you pass into Create is a complexity indicator. The higher the number, the longer the name, but this does not equate to the actual length of the name. Names are generated in pairs of vowels and consonants.

Here are some example names that have been generated. Obviously, they are not like common names like Dave, Geoff or Keith, but they are readable :-)

* pumufo

* fifeli

* xucowokae

* luwusaelae

* faeduxegymo


## Why Would you Need This?

There are a few situations where this might be useful. The first situation could be if you have a game where you need to generate characters with non-English sounding names. This is something I am doing, hence why I wrote this simple library. Another use case is if you need to use production data in a test environment. You may want to anonymize the data by replacing the first and last names in the tables. This library can be used to generate English readable, but non-standard names for test data.
