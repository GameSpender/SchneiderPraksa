#include "GenericElement.h"


    GenericElement generateRandomElement(int id) {
        GenericElement elem;
        elem.id = id;

        for (int i = 0; i < VALUES_LENGTH; i++) {
            elem.values[i] = rand();
        }
        return elem;
    }

    void printElement(const GenericElement& elem, ostream& output) {
        output << elem.id << " ";
        for (int i = 0; i < VALUES_LENGTH; i++) {
            output << elem.values[i] << " ";
        }
    }

    void printElementVector(vector<GenericElement> elemVector, ostream& output) {
        for (auto elem : elemVector) {
            printElement(elem, output);
            output << endl;
        }
    }

    /*bool operator==(GenericElement& elem, int id) {
        return elem.id == id;
    }

    bool operator==(int id, GenericElement& elem) {
        return elem.id == id;
    }

    ostream& operator<<(ostream& stream, const GenericElement& elem) {

        return stream;
    }*/

    // parsiranje GenericElement-a iz stringa
    GenericElement parseStringToElement(string data) {
        stringstream sstream(data);
        GenericElement elem;

        sstream >> elem.id;
        for (int i = 0; i < VALUES_LENGTH; i++) {
            if (sstream.eof())
                elem.values[i] = -1;
            sstream >> elem.values[i];
        }
        return elem;
    }


    // ispis GenericElement-a u dati ofstream
    //void writeElementsToFile(vector<GenericElement> elementVector, ofstream& file) {
    //    if (!file.is_open())
    //        return;
    //    printElementVector(elementVector, file);
    //}

    vector<GenericElement> readElementsFromFile(ifstream& file) {
        vector<GenericElement> elementVector;
        string temp;
        int i = 0;
        while (!file.eof()) {
            getline(file, temp);
            elementVector.push_back(parseStringToElement(temp));
        }
        return elementVector;
    }

// 
