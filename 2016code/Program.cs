
using System;
using System.Collections.Generic;


public class HashTable<k, v> {
    List<v> storeData= new List<v>();
   
    private int count = 0;
    public HashTable() {
    }

    public void put(k key, v value) {
        int hasCode = getHashCode(key);
        storeData[hasCode] = value;

    }

    
    public int getHashCode(k key) {
        return count++;
    }
    public v get(k key) {


    }
}

