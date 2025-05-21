public class Trie {

    public class TrieNode{
        public TrieNode[]children = new TrieNode[26];
        public bool isWord = false;
    }

    TrieNode root;

    public Trie() {
       this.root = new TrieNode(); 
    }
    
    public void Insert(string word) {
        TrieNode curr = root;
        foreach(char c in word){
            int index = c - 'a';
            if(curr.children[index] == null){
                curr.children[index] = new TrieNode();
            }
            curr = curr.children[index];
        }
        curr.isWord = true;
    }
    
    public bool Search(string word) {
        TrieNode curr = root;
        foreach(char c in word){
            int index = c - 'a';
            if(curr.children[index]==null){
                return false;
            }
            curr = curr.children[index];
        }
        return curr.isWord;
    }
    
    public bool StartsWith(string prefix) {
        TrieNode curr = root;
        foreach(char c in prefix){
            int index = c - 'a';
            if(curr.children[index]==null){
                return false;
            }
            curr = curr.children[index];
        }
        return true;
    }
}

/**
 * Your Trie object will be instantiated and called as such:
 * Trie obj = new Trie();
 * obj.Insert(word);
 * bool param_2 = obj.Search(word);
 * bool param_3 = obj.StartsWith(prefix);
 */