public class TrieNode{
    public TrieNode[]children;
    public bool isWord;
    public TrieNode(){
        this.children = new TrieNode[26];
        this.isWord = false;
    }
}

public class Solution {
    
    string biggest = "";
    public void Recurse(TrieNode curr, StringBuilder word){
        if(curr == null || !curr.isWord){
            return;
        }
        if(curr.isWord && word.ToString().Length>biggest.Length){
            biggest = word.ToString();
        }
        for(int i = 0; i<26; i++){
            TrieNode child = curr.children[i];
            char c = (char)(i+'a');
            word.Append(c);
            Recurse(child, word);
            word.Length--;
        } 
    }

    public string LongestWord(string[] words) {
        //populate my Trie
        TrieNode root = new TrieNode();
        root.isWord = true;
        foreach(string word in words){
            TrieNode curr = root;
            for(int i = 0; i<word.Length; i++){
                char c = word[i];
                int index = (int)(c-'a');
                if(curr.children[index]==null){
                    curr.children[index]= new TrieNode();
                }
                curr = curr.children[index];
            }
            curr.isWord = true;
        }
        // search my Trie for biggest word with isWord == true
        Recurse(root, new StringBuilder());
        return biggest;
      
    }
}