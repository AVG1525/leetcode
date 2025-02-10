public class Solution {
    public bool DetectCapitalUse(string word) {
        if (word.Equals(word.ToUpper()) || word.Equals(word.ToLower())) {
            return true;
        }

        var initialLetter = word.Substring(0, 1);
        var wordWithoutInitialLetter = word.Substring(1, (word.Length -1));

        return (initialLetter.Equals(initialLetter.ToUpper()) && wordWithoutInitialLetter.Equals(wordWithoutInitialLetter.ToLower()));
    }
}