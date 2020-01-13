using System;
using System.Threading.Tasks;

namespace T4Test {

	public class Program {
		
		static void Main(string[] args) {
			
			// 実際にはここで色々必要な情報を揃える
			var context = new GeneratorContext() {
				Params = new [] {
					new GeneratorParam {
						ClassName = "RuntimeIntPerson",
						Type = "int",
						PropertyName = "IntField",
					},
					new GeneratorParam {
						ClassName = "RuntimeFloatPerson",
						Type = "float",
						PropertyName = "FloatField",
					},
					new GeneratorParam {
						ClassName = "RuntimeLongPerson",
						Type = "long",
						PropertyName = "LongField",
					},
				},
			};
			
			var generatedText = new RuntimePersonGenerator(context).TransformText();
			Console.WriteLine(generatedText);
		}

	}

}