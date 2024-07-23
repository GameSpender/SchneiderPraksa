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

using namespace std;

#define NAME_LENGTH 5
#define VALUES_LENGTH 14
#define ELEMENT_COUNT 1000

// id, 14 proizvoljnih int vrednosti
struct GenericElement {
    int id;
    int values[VALUES_LENGTH];
};

GenericElement generateRandomElement(int id) {
    GenericElement elem;
    elem.id = id;

    for (int i = 0; i < VALUES_LENGTH; i++) {
        elem.values[i] = rand();
    }
    return elem;
}

void printElement(GenericElement& elem, ostream& output) {
    output << elem.id << " ";
    for (int i = 0; i < VALUES_LENGTH; i++) {
        output << elem.values[i] << " ";
    }
}

void saveElementsToFile(GenericElement* elements, int count, ofstream file) {
    if (!file.is_open())
        return;
    for (int i = 0; i < count; i++) {

    }
}

int main()
{
    cout << "Hello World!" << endl;
    GenericElement testElem = generateRandomElement(1);
    printElement(testElem, cout);
    cout << endl;
    auto start = chrono::high_resolution_clock::now();
    testElem = generateRandomElement(1300);
    auto end = chrono::high_resolution_clock::now();
    printElement(testElem, cout);
    cout << endl << "time: " << chrono::duration_cast<chrono::nanoseconds>(end - start).count() << endl;


    GenericElement elementArray[ELEMENT_COUNT];
    for (int i = 0; i < ELEMENT_COUNT; i++) {
        elementArray[i] = generateRandomElement(i);
    }
}
