# Kogane Destroy Event Listener

ゲームオブジェクトが破棄された時にイベントを実行するコンポーネント

## 使用例

```csharp
using Kogane;
using UnityEngine;

public class Example : MonoBehaviour
{
    private void Awake()
    {
        var listener = gameObject.AddComponent<DestroyEventListener>();
        listener.OnDestroyed += () => Debug.Log( "OnDestroy" );
    }
}
```