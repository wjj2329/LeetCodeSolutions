public class AuthenticationManager {

    int timeToLive = 0;
    Dictionary<string, int>tokens = new Dictionary<string, int>();
    public AuthenticationManager(int timeToLive) {
        this.timeToLive =timeToLive; 
    }
    
    public void Generate(string tokenId, int currentTime) {
        tokens.Add(tokenId, currentTime);
    }
    
    public void Renew(string tokenId, int currentTime) {
        if(tokens.ContainsKey(tokenId)&&currentTime-tokens[tokenId]<timeToLive)
            tokens[tokenId]= currentTime;
    }
    
    public int CountUnexpiredTokens(int currentTime) {
        int count = 0; 
        foreach(string key in tokens.Keys){
            if(currentTime-tokens[key]<timeToLive){
                count++;
            }
        }
        return count;
    }
}

/**
 * Your AuthenticationManager object will be instantiated and called as such:
 * AuthenticationManager obj = new AuthenticationManager(timeToLive);
 * obj.Generate(tokenId,currentTime);
 * obj.Renew(tokenId,currentTime);
 * int param_3 = obj.CountUnexpiredTokens(currentTime);
 */