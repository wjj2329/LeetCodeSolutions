public class Trie {
    public class TrieNode{
       public TrieNode[] children = new TrieNode[26];
       public int prefix = 0;
       public int wordCount = 0; 
    }
    TrieNode root;
    public Trie() {
        root = new TrieNode();
    }
    
    public void Insert(string word) {
        TrieNode curr = root;
        foreach(char c in word){
            int index = c - 'a';
            if(curr.children[index] == null){
                curr.children[index] = new TrieNode();
            }
            curr.children[index].prefix++;
            curr = curr.children[index];
        }
        curr.wordCount++;
    }
    
    public int CountWordsEqualTo(string word) {
        TrieNode curr = root;
        foreach(char c in word){
            int index = c - 'a';
            if(curr.children[index] == null){
                return 0;
            }
            curr = curr.children[index];
        }
        return curr.wordCount;
    }
    
    public int CountWordsStartingWith(string prefix) {
        TrieNode curr = root;
        foreach(char c in prefix){
            int index = c - 'a';
            if(curr.children[index] == null){
                return 0;
            }
            curr = curr.children[index];
        }
        return curr.prefix;
    }
    
    public void Erase(string word) {
        TrieNode curr = root;
        foreach(char c in word){
            int index = c - 'a';
            if(curr.children[index] == null){
                return;
            }
            curr.children[index].prefix--;
            curr = curr.children[index];
        }
        curr.wordCount--;
    }
}

/**
 * Your Trie object will be instantiated and called as such:
 * Trie obj = new Trie();
 * obj.Insert(word);
 * int param_2 = obj.CountWordsEqualTo(word);
 * int param_3 = obj.CountWordsStartingWith(prefix);
 * obj.Erase(word);
 */