//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v2.2.1.0).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class Test2Entity
{
	public ClassToGenerateComponent ClassToGenerate { get { return (ClassToGenerateComponent)GetComponent(Test2ComponentsLookup.ClassToGenerate); } }
	public bool HasClassToGenerate { get { return HasComponent(Test2ComponentsLookup.ClassToGenerate); } }

	public void AddClassToGenerate(EntitasRedux.Tests.ClassToGenerate newValue)
	{
		var index = Test2ComponentsLookup.ClassToGenerate;
		var component = (ClassToGenerateComponent)CreateComponent(index, typeof(ClassToGenerateComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.value = newValue;
		#endif
		AddComponent(index, component);
	}

	public void ReplaceClassToGenerate(EntitasRedux.Tests.ClassToGenerate newValue)
	{
		var index = Test2ComponentsLookup.ClassToGenerate;
		var component = (ClassToGenerateComponent)CreateComponent(index, typeof(ClassToGenerateComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.value = newValue;
		#endif
		ReplaceComponent(index, component);
	}

	public void CopyClassToGenerateTo(ClassToGenerateComponent copyComponent)
	{
		var index = Test2ComponentsLookup.ClassToGenerate;
		var component = (ClassToGenerateComponent)CreateComponent(index, typeof(ClassToGenerateComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.value = copyComponent.value;
		#endif
		ReplaceComponent(index, component);
	}

	public void RemoveClassToGenerate()
	{
		RemoveComponent(Test2ComponentsLookup.ClassToGenerate);
	}
}

//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v2.2.1.0).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class Test2Entity : IClassToGenerateEntity { }

//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v2.2.1.0).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class Test2Matcher
{
	static JCMG.EntitasRedux.IMatcher<Test2Entity> _matcherClassToGenerate;

	public static JCMG.EntitasRedux.IMatcher<Test2Entity> ClassToGenerate
	{
		get
		{
			if (_matcherClassToGenerate == null)
			{
				var matcher = (JCMG.EntitasRedux.Matcher<Test2Entity>)JCMG.EntitasRedux.Matcher<Test2Entity>.AllOf(Test2ComponentsLookup.ClassToGenerate);
				matcher.ComponentNames = Test2ComponentsLookup.ComponentNames;
				_matcherClassToGenerate = matcher;
			}

			return _matcherClassToGenerate;
		}
	}
}
