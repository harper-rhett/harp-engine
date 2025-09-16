# <a id="HarpEngine_Utilities_FireTimer"></a> Class FireTimer

Namespace: [HarpEngine.Utilities](HarpEngine.Utilities.md)  
Assembly: HarpEngine.dll  

```csharp
public class FireTimer : Entity
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Entity](HarpEngine.Entity.md) ← 
[FireTimer](HarpEngine.Utilities.FireTimer.md)

#### Inherited Members

[Entity.scene](HarpEngine.Entity.md\#HarpEngine\_Entity\_scene), 
[Entity.IsUpdating](HarpEngine.Entity.md\#HarpEngine\_Entity\_IsUpdating), 
[Entity.IsRendering](HarpEngine.Entity.md\#HarpEngine\_Entity\_IsRendering), 
[Entity.UpdateLayer](HarpEngine.Entity.md\#HarpEngine\_Entity\_UpdateLayer), 
[Entity.DrawLayer](HarpEngine.Entity.md\#HarpEngine\_Entity\_DrawLayer), 
[Entity.Update\(float\)](HarpEngine.Entity.md\#HarpEngine\_Entity\_Update\_System\_Single\_), 
[Entity.Draw\(\)](HarpEngine.Entity.md\#HarpEngine\_Entity\_Draw), 
[Entity.DrawGUI\(\)](HarpEngine.Entity.md\#HarpEngine\_Entity\_DrawGUI), 
[Entity.Remove\(\)](HarpEngine.Entity.md\#HarpEngine\_Entity\_Remove), 
[Entity.OnRemove\(\)](HarpEngine.Entity.md\#HarpEngine\_Entity\_OnRemove), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="HarpEngine_Utilities_FireTimer__ctor_HarpEngine_Scene_System_Single_"></a> FireTimer\(Scene, float\)

```csharp
public FireTimer(Scene scene, float cooldownTime)
```

#### Parameters

`scene` [Scene](HarpEngine.Scene.md)

`cooldownTime` [float](https://learn.microsoft.com/dotnet/api/system.single)

## Fields

### <a id="HarpEngine_Utilities_FireTimer_CooldownTime"></a> CooldownTime

```csharp
public float CooldownTime
```

#### Field Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="HarpEngine_Utilities_FireTimer_Draw"></a> Draw\(\)

```csharp
public override void Draw()
```

### <a id="HarpEngine_Utilities_FireTimer_OnFired"></a> OnFired\(\)

```csharp
protected virtual void OnFired()
```

### <a id="HarpEngine_Utilities_FireTimer_Start"></a> Start\(\)

```csharp
public void Start()
```

### <a id="HarpEngine_Utilities_FireTimer_Update_System_Single_"></a> Update\(float\)

```csharp
public override void Update(float frameTime)
```

#### Parameters

`frameTime` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="HarpEngine_Utilities_FireTimer_Fired"></a> Fired

```csharp
public event FireTimer.FiredDelegate Fired
```

#### Event Type

 [FireTimer](HarpEngine.Utilities.FireTimer.md).[FiredDelegate](HarpEngine.Utilities.FireTimer.FiredDelegate.md)

