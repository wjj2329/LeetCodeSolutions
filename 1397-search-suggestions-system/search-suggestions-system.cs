public class Solution {

    public class TrieNode{
        public TrieNode[]children = new TrieNode[26];
        public bool isWord = false;
    }

    public void GetWords(TrieNode curr, StringBuilder sb, IList<string>suggestions){
        if(suggestions.Count>=3) return;

        if(curr.isWord)
            suggestions.Add(sb.ToString());
        
        for(int i = 0; i < 26; i++){
            if(curr.children[i] != null){
                sb.Append((char)(i + 'a'));
                GetWords(curr.children[i], sb, suggestions);
                sb.Length--;
            }
        }
    }
    
    public IList<IList<string>> SuggestedProducts(string[] products, string searchWord) {
        TrieNode root = new TrieNode();
        TrieNode curr;
        foreach(string s in products){
            curr = root;
            foreach(char c in s){
                int index = (int)(c-'a');
                if(curr.children[index] == null){
                    curr.children[index] = new TrieNode();
                }
                curr = curr.children[index];
            }
            curr.isWord = true;
        }
        IList<IList<string>>result = new List<IList<string>>();
        curr = root;
        for(int i = 0; i < searchWord.Length; i++){
            int index = searchWord[i] - 'a';
            if(curr!=null){
                curr = curr.children[index];
            }
            IList<string>suggestions = new List<string>();
            if(curr != null){
                GetWords(curr, new StringBuilder(searchWord.Substring(0, i+1)), suggestions);
            }
            result.Add(suggestions);
        } 
        return result;
    }
}