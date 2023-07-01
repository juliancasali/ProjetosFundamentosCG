#version 430

in vec3 vsPosition;
in vec3 vsColor;
in vec2 vsTexCoord;
in vec3 vsNormal;

out vec4 color;

//Propriedades da superficie
uniform float ka;
uniform float kd;
uniform float ks;
uniform float Ke;

//Propriedades da fonte de luz
uniform vec3 lightPos;
uniform vec3 lightColor;

// Camera
uniform vec3 viewPos;

uniform sampler2D texSampler;

void main()
{
	// ambiente
	vec3 ambient = ka * lightColor;

	// Calculando a cor difusa
	vec3 norm = normalize(vsNormal);
	vec3 lightDir = normalize(lightPos - vsPosition);
	float diff = max(dot(norm, lightDir), 0.0);
	vec3 diffuse = diff * lightColor;

	// Calculando espetacular
	vec3 viewDir = normalize(viewPos - vsPosition);
	vec3 reflectDir = normalize(reflect(-lightDir, norm));
	float spec = pow(max(dot(viewDir, reflectDir), 0.0), 90);
	vec3 specular = spec * lightColor;

	vec4 texColor = texture(texSampler, vsTexCoord);

	vec3 result = (ambient + diffuse + specular) * vec3(texColor);

	color = vec4(result, 1.0);

	//color = texture(texSampler, vsTexCoord);	
}