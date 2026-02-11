class HashTable:
    def __init__(self):
        self.collection = {}
    def hash(self, string):
        return sum([ord(i) for i in string])
    def add(self, key, value):
        newKey = self.hash(key)
        if newKey not in self.collection.keys():
            self.collection[newKey] = {key: value}
        else:
            self.collection[newKey][key] = value
    def remove(self, key):
        newKey = self.hash(key)
        if newKey in self.collection.keys():
            if key in self.collection[newKey].keys():
                del self.collection[newKey][key]
    def lookup(self, key):
        newKey = self.hash(key)
        if newKey in self.collection.keys():
            if key in self.collection[newKey].keys():
                return self.collection[newKey][key]
        return None