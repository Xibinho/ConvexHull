; A class to wrap a List<T> coming from .NET
; Converts 0-based indexes to 1-based, provides enumerator, Count() etc
Class ListWrapper {
	__New(list){
		this.List := list
		; https://www.autohotkey.com/boards/viewtopic.php?p=155453#p155453
		this.ICollection := ComObject(9, ComObjQuery(this.List, "{DE8DB6F8-D101-3A92-8D1C-E72E5F10E992}"), 1)
		this.IList := ComObject(9, ComObjQuery(this.ICollection, "{7BCFA00F-F764-3113-9140-3BBD127A96BB}"), 1)
	}
	
	; Handle index lookups ([1], [2] etc)
	__Get(i){
		return this.IList.Item(i - 1)
	}
	
	; === Enumerator code to handle for loops
	; https://www.autohotkey.com/boards/viewtopic.php?f=7&t=7199
	_NewEnum(){
		this.i := 0
		return this
	}
	
	Next(ByRef k, ByRef v){
		this.i++
		if (this.i > this.Count()){
			return False
		}
		k := this.i
		v := this[k]
		return True
	}
	
	; ==== Count, MaxIndex etc
	Count(){
		return this.ICollection.Count()
	}
	
	MaxIndex(){
		return this.ICollection.Count()
	}
	
	Length(){
		return this.ICollection.Count()
	}
}