
 var lengthOfLastWord = function(s) {
    
    const words = s.trim().split(" ");
     if (words.length < 1) {
         return 0;
     }
     
     return (words[words.length - 1].length + "\n");
     
 }
