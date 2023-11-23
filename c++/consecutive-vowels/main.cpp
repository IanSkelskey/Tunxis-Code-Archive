#include <iostream>
#include <fstream>
#include <string>
#include <cstdlib>

using namespace std;

string mostVowels;
int nbrVowels = 0;
string tempString;       //stores one word of words.txt at a time
char tempChar;           //stores a letter for comparison
char tempChar2;         //stores a second letter for comparison
//int wordCntr = 0;

int main()
{

    ifstream file;                      //declares input stream
    file.open("words.txt");              //opens file
    if(!file.is_open()) {               //terminates program if file is not open (part of c standard library)
        exit(EXIT_FAILURE);             //will probably replace with a way to reset input loop
    }
    while (getline(file, tempString))
    {
        //integer for index of temporary string
        int i = 0;
        int counter = 0; //variable to store number of consecutive vowels in each word
        while (tempString[i] != '\0')
        {
            tempChar = tempString[i];
            tempChar2 = tempString[i+1];
            if (tempChar == 'a' || tempChar == 'A' || tempChar == 'e' || tempChar == 'E' || tempChar == 'i' || tempChar == 'I' || tempChar == 'o' || tempChar == 'O' || tempChar == 'u' || tempChar == 'U')
            {
                i++;
                counter++;
            }
            else
            {
                i++;
                counter = 0;
            }

            /* I used this to find the word "aqueous"
             * described in the text to verify
             * that the program was working correctly.
             *
             *
            if (counter == 4)
                cout << tempString << endl;
            */

            if (counter >= nbrVowels)
            {
                nbrVowels = counter;
                mostVowels = tempString;
            }
        }
    }
    cout << "The word with the most consecutive vowels is: " << mostVowels << endl;
    cout << mostVowels << " has " << nbrVowels << " consecutive vowels." << endl;

    return 0;
}
