//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v1.3.0, branch:develop).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial interface IClassToGenerateEntity
{
	ClassToGenerateComponent ClassToGenerate { get; }
	bool HasClassToGenerate { get; }

	void AddClassToGenerate(EntitasRedux.Tests.ClassToGenerate newValue);
	void ReplaceClassToGenerate(EntitasRedux.Tests.ClassToGenerate newValue);
	void RemoveClassToGenerate();
}
