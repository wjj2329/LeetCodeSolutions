/**
 * @param {number} n
 * @return {Function} counter
 */
var createCounter = function(n) {
    var s = n;
    return function() {
        var c = s;
        s+=1;
        return c;
    };
};

/** 
 * const counter = createCounter(10)
 * counter() // 10
 * counter() // 11
 * counter() // 12
 */