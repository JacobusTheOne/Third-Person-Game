using UnityEngine;
using System.Collections;

public class DoorOpenDevice : MonoBehaviour {
	[SerializeField] private Vector3 dPos;

	private bool _open;

	public void Operate() {
		if (_open)
        {
            CloseDoor();
        }
        else
        {
            OpenDoor();
        }
        _open = !_open;
	}

    private void OpenDoor()
    {
        Vector3 pos = transform.position + dPos;
        LeanTween.move(this.gameObject, pos, 1f);
    }

    private void CloseDoor()
    {
        Vector3 pos = transform.position - dPos;
        LeanTween.move(this.gameObject,pos,1f);
    }

    public void Activate() {
		if (!_open) {
            OpenDoor();
			_open = true;
		}
	}
	public void Deactivate() {
		if (_open) {
            CloseDoor();
			_open = false;
		}
	}
}
