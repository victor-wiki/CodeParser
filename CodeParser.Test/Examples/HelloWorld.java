package demo;

import java.io.File;
import java.util.List;

public interface ISpeech {  
   final int count=0;
   void sayHello(String word);
}

public class JavaHelloWorld extends ISpeech {

	public String _name;
	
	public String getName() {
		return this._name;
	}
	
	public void setName(String name) {
		this._name=name;
	}
	
	public void sayHello(String word) {
		System.out.println(word);
	}
}
