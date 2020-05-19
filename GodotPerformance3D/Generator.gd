extends Spatial

const CUBE = preload("res://Cube.tscn")

onready var text = get_node("/root/Spatial/Control/Text")

var cubes = 0

func _ready():
	var timer = Timer.new()
	timer.connect("timeout",self,"_on_timer_timeout")
	add_child(timer)
	timer.start(0.1)
	
	
func _on_timer_timeout():
	var instance = CUBE.instance()
	add_child(instance)
	
	var x = 0
	var z = 0
	
	if (randf() > 0.5):
		x = randf() * 5
		z = randf() * 5
	else:
		x = randf() * -5
		z = randf() * -5
		
	instance.translate(Vector3(x, 0, z))
	
	cubes = cubes+1
	
	var os_name = OS.get_name()
	if OS.has_feature('JavaScript') and os_name == "HTML5":
		os_name = JavaScript.eval("navigator.userAgent")
	
	text.text = "GODOT PERFORMANCE 3D: \nPlatform: " + os_name + "\nCubes: " + str(cubes) + "\nFPS: " + str(Engine.get_frames_per_second())

