#include <iostream>
#include <fstream>
#include <string>

using namespace std;

int main()
{
    int n;

    while (true) {

        /*Menu Contents*/
        cout << "***** Welcome to PACS! *****" << endl;
        cout << "Choose an option:" << endl;
        cout << "[1] C-STORE" << endl;
        cout << "[2] C-FIND" << endl;
        cout << "[3] C-GET" << endl;
        cout << "[4] C-ECHO" << endl;
        cout << "[5] Exit the program" << endl;
        cout << "Enter choice [1-5]: ";
        cin >> n;

    if (n == 1) {
        string image_filename;
        cout << "Enter image filename: ";
        cin >> image_filename;
        ofstream myfile;
        myfile.open ("file.txt");
        myfile << image_filename;
        myfile.close();
        cout << "Image successfully stored." << endl << endl;
        n = 0;
    }
    else if (n == 2) {
        string filename_query;
        cout << "Enter filename for verification: ";
        cin >> filename_query;
    }
    else if (n == 3) {

        string filename_query;
        cout << "Enter filename to view its contents: ";
        cin >> filename_query;
        ifstream myfile;
        myfile.open (filename_query);
        ifstream myfile("file.txt");

        if (myfile.is_open())
            cout << f.rdbuf() << endl;
        else
            cout << "failed to open file" << endl;
    }
    else if (n == 4) {
        cout << "Hello." << endl << endl;
    }
    else if (n == 5) {
        break;
    }
    else {
        cout << "Please input an integer in the specified range [1-5]." << endl;
        n = 0;
    //program still does not handle floating-point input
    }
}
    return 0;
}
