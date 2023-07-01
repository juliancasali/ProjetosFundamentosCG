#version 430

layout (location = 0) in vec3 position;
layout (location = 1) in vec3 color;
layout (location = 2) in vec2 texCoord;
layout (location = 3) in vec3 normal;

out vec3 vsPosition;
out vec3 vsColor;
out vec2 vsTexCoord;
out vec3 vsNormal;

uniform mat4 model;
uniform mat4 view;
uniform mat4 projection;

void main()
{
	gl_Position = projection * view * model * vec4(position, 1.0);
	vsPosition = vec3(model * vec4(position, 1.0));
	vsColor = color;
	vsTexCoord = vec2(texCoord.x, 1.0 - texCoord.y );
	vsNormal = normal;
}