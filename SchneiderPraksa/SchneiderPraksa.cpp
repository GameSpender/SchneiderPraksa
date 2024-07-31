//Miloš Herceg

//Implementacija testne aplikacije koja skladišti 10M automatski generisanih elemenata.Element je struktura sa 15 polja, od kojih je prvo ID koji je int tip.
//Izmeriti vreme pretrage određenog elementa ako se podaci čuvaju u nizu
//Izmeriti vreme pretrage određenog elementa ako se podaci čuvaju u listi
//Izmeriti vreme pretrage određenog elementa ako se podaci čuvaju u hashset / mapi
//Produskutovati i potencijalno optimizovati kod.

#include <iostream>
#include <string>
#include <fstream>
#include <chrono>
#include <sstream>
#include <vector>

//#include "TestingFunctions.h"
#include "GenericElement.h"

using namespace std;


int main()
{
    cout << "Hello World!" << endl;


    //GenericElement testElem = generateRandomElement(1);
    //printElement(testElem, cout);
    //cout << endl;

    //auto start = chrono::high_resolution_clock::now();
    //testElem = generateRandomElement(1300);
    //auto end = chrono::high_resolution_clock::now();
    //printElement(testElem, cout);
    //cout << endl << "time: " << chrono::duration_cast<chrono::nanoseconds>(end - start).count() << endl;

    //string testString("69 1 2 3 4 5 6 7 8 9 10");
    //testElem = parseStringToElement(testString);
    //printElement(testElem, cout);
    //cout << endl;


    //vector<GenericElement> elementVector;
    //for (int i = 0; i < ELEMENT_COUNT; i++) {
    //    elementVector.push_back(generateRandomElement(i));
    //}

    //ofstream outputFile("genericElement100000.txt");
    ////writeElementsToFile(elementVector, outputFile);
    //printElement(elementVector, outputFile);
    //outputFile.close();


    //ifstream inputFile("genericElementAny.txt");
    //if (inputFile.is_open()) {
    //    elementVector = readElementsFromFile(inputFile);
    //    printElement(elementVector, cout);
    //}
    //else
    //{
    //    cout << "cannot open file" << endl;
    //}

    /*if (tryFindId(69, testElem, elementVector)) {
        cout << "Found element with id 69" << endl;
        cout << testElem << endl;
    }*/
}
