//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v1.3.0, branch:develop).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class VisualDebugEntity
{
	public ExampleContent.VisualDebugging.MyFloatComponent MyFloat { get { return (ExampleContent.VisualDebugging.MyFloatComponent)GetComponent(VisualDebugComponentsLookup.MyFloat); } }
	public bool HasMyFloat { get { return HasComponent(VisualDebugComponentsLookup.MyFloat); } }

	public void AddMyFloat(float newMyFloat)
	{
		var index = VisualDebugComponentsLookup.MyFloat;
		var component = (ExampleContent.VisualDebugging.MyFloatComponent)CreateComponent(index, typeof(ExampleContent.VisualDebugging.MyFloatComponent));
		component.myFloat = newMyFloat;
		AddComponent(index, component);
	}

	public void ReplaceMyFloat(float newMyFloat)
	{
		var index = VisualDebugComponentsLookup.MyFloat;
		var component = (ExampleContent.VisualDebugging.MyFloatComponent)CreateComponent(index, typeof(ExampleContent.VisualDebugging.MyFloatComponent));
		component.myFloat = newMyFloat;
		ReplaceComponent(index, component);
	}

	public void CopyMyFloatTo(ExampleContent.VisualDebugging.MyFloatComponent copyComponent)
	{
		var index = VisualDebugComponentsLookup.MyFloat;
		var component = (ExampleContent.VisualDebugging.MyFloatComponent)CreateComponent(index, typeof(ExampleContent.VisualDebugging.MyFloatComponent));
		component.myFloat = copyComponent.myFloat;
		ReplaceComponent(index, component);
	}

	public void RemoveMyFloat()
	{
		RemoveComponent(VisualDebugComponentsLookup.MyFloat);
	}
}

//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v1.3.0, branch:develop).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class VisualDebugMatcher
{
	static JCMG.EntitasRedux.IMatcher<VisualDebugEntity> _matcherMyFloat;

	public static JCMG.EntitasRedux.IMatcher<VisualDebugEntity> MyFloat
	{
		get
		{
			if (_matcherMyFloat == null)
			{
				var matcher = (JCMG.EntitasRedux.Matcher<VisualDebugEntity>)JCMG.EntitasRedux.Matcher<VisualDebugEntity>.AllOf(VisualDebugComponentsLookup.MyFloat);
				matcher.ComponentNames = VisualDebugComponentsLookup.ComponentNames;
				_matcherMyFloat = matcher;
			}

			return _matcherMyFloat;
		}
	}
}
