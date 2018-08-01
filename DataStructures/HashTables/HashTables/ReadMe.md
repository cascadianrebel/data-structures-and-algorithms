# Hashtables
Implementation of an example Hashtable

## Explanation
A hashtable is data structure formatted as an array of "buckets."

Buckets are simply a key/value pair stored in a certain index position within the hashtable(array). 

In a hashtable, index positions can multiple buckets but a "perfect" hash table only has one bucket per index position.

## Use Cases
The HashTable could be thought of as a dictionary. In this application, we're storing cities (values) within their respective states (Keys). 

A Hashtable would also be well used to store data with a somewhat randomized index positions. This would prevent hackers from easily targeting key value pairs. 
 
## Visual
![Visual of Hashtables](http)

![Visual of ConsoleApp](http)

## Specs
The Hashtable is able to handle the following:

- Add an item to a hashtable.(Method name: Add(key, value))
- Get a value from a key (Method name: Find(key))
- Make a hashing algorithm that will determine and set the Key of your Key/Value Pair(Method Name: GetHash(key))
- Handle collisions in the event that 2 keys equal the same

## Author
Anthony Green