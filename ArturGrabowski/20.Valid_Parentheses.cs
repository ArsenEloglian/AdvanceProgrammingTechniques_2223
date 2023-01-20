public class Solution {
    public bool IsValid(string s) {
        char[] left_pars = {'(', '{', '['};
        char[] right_pars = {')', '}', ']'};

        Stack stack = new Stack();

        foreach (char c in s) {
            if (right_pars.Contains(c)){
                if (stack.Count == 0) return false;

                if (Array.IndexOf(right_pars, c) != Array.IndexOf(left_pars, stack.Pop()))
                    return false;                    
            }
            else stack.Push(c);
        }

        if (stack.Count != 0) return false;
        return true;
    }
}
