#pragma once

#include <iostream>
#include <fstream>
#include <vector>
#include <sstream>

using namespace std;

#define NAME_LENGTH 5
#define VALUES_LENGTH 14
#define ELEMENT_COUNT 100000

// id, 14 proizvoljnih int vrednosti

struct GenericElement {
    int id;
    int values[VALUES_LENGTH];
};

GenericElement generateRandomElement(int id);

void printElement(GenericElement& elem, ostream& output);

void printElementVector(vector<GenericElement> elemVector, ostream& output);

ofstream& operator<<(ostream& stream, GenericElement& elem);

bool operator==(GenericElement& elem, int id);
bool operator==(int id, GenericElement& elem);

// parsiranje GenericElement-a iz stringa
GenericElement parseStringToElement(string data);

// ispis GenericElement-a u dati ofstream
//void writeElementsToFile(vector<GenericElement> elementVector, ofstream& file);

vector<GenericElement> readElementsFromFile(ifstream& file);