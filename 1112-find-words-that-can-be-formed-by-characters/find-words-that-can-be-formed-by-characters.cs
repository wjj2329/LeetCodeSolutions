public class Solution {
    public int CountCharacters(string[] words, string chars)
{
    int count = 0;
    Dictionary<char, int> charsDict = new Dictionary<char, int>();
    foreach ( char s in chars)
    {
        if (!charsDict.ContainsKey(s))
        {
            charsDict.Add(s, 0);
        }
        charsDict[s]++;
    }
    
    foreach (string word in words)
    {
        Dictionary<char, int> temp = new Dictionary<char, int>(charsDict);
        bool isWord = true;
        foreach(char s in word)
        {
           if(!temp.ContainsKey(s))
            {
                isWord = false;
                continue;
            }
            temp[s]--;
            if (temp[s]==0)
            {
                temp.Remove(s);
            }
        }
        if(isWord){
        count += word.Length;
        }
    }
    return count;

}
}