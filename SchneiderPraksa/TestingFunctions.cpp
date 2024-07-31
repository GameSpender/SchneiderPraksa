#include "TestingFunctions.h"


//GenericElement findId(vector<GenericElement> elemVector, int id) {
//	return *find(elemVector.begin(), elemVector.end(), id);
//}

//GenericElement findId(GenericElement* elemArray, int size, int id) {
//	for (int i = 0; i < size; i++) {
//		if (elemArray[i].id == id) {
//			return elemArray[i];
//		}
//	}
//}

bool tryFindId(int id, GenericElement& outElem, vector<GenericElement> elemVector) {
	auto it = find(elemVector.begin(), elemVector.end(), id);
	if (it == elemVector.end()) {
		return false;
	}
	outElem = *it;
	return true;
}

bool tryFindId(int id, GenericElement& outElem, GenericElement* elemArray, int size) {
	for (int i = 0; i < size; i++) {
		if (elemArray[i].id == id) {
			outElem = elemArray[i];
			return true;
		}
	}
	return false;
}

bool tryFindId(int id, GenericElement& outElem, list<GenericElement> elemList) {
	auto it = find(elemList.begin(), elemList.end(), id);
	if (it == elemList.end()) {
		return false;
	}
	outElem = *it;
	return true;
}

bool tryFindId(int id, GenericElement& outElem, unordered_map<int, GenericElement> elemMap) {
	auto it = elemMap.find(id);
	if (it == elemMap.end()) {
		return false;
	}
	outElem = it->second;
	return true;
}