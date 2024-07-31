#pragma once

#include "GenericElement.h"
#include <vector>
#include <list>
#include <unordered_map>

using namespace std;

//GenericElement findId(vector<GenericElement> elemVector, int id);
//GenericElement findId(GenericElement* elemArray, int size, int id);

bool tryFindId(int id, GenericElement& outElem, vector<GenericElement> elemVector);
bool tryFindId(int id, GenericElement& outElem, GenericElement* elemArray, int size);
bool tryFindId(int id, GenericElement& outElem, list<GenericElement> elemList);
bool tryFindId(int id, GenericElement& outElem, unordered_map<int, GenericElement> elemMap);