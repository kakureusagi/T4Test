namespace T4Test {

	public partial class RuntimePersonGenerator {

		GeneratorContext Context { get; }

		public RuntimePersonGenerator(GeneratorContext context) {
			Context = context;
		}
		
	}

	public class GeneratorContext {
		public GeneratorParam[] Params { get; set; }
	}

	public class GeneratorParam {
		
		public string ClassName { get; set; }

		public string PropertyName { get; set; }

		public string Type { get; set; }
	}
}