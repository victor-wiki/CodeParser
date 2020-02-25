import { Helper } from '/modules/util.js';

var owner = "";

function test(word) {
    var helloWord = new helloWord();
    helloWord.sayHello(word);
}

var helloWord = {
    owner: "",
    target: "",
    sayHello: function (word) {
        alert(word);
    }
};

export function sayHello(word) {
    test("Hello");
}

export { sayHello as say };