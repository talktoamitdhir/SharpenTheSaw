import openai
import requests
import os

# Set your OpenAI API key
openai.api_key = 'YOUR_API_KEY_HERE'

def generate_image(prompt, output_path, num_images=1):
    response = openai.Image.create(
        engine="dalle",
        prompt=prompt,
        max_tokens=100,
        temperature=0.7,
        num_images=num_images
    )
    images = response['images']
    for idx, image_url in enumerate(images):
        image_response = requests.get(image_url)
        with open(f'{output_path}_{idx}.png', 'wb') as f:
            f.write(image_response.content)

def main():
    prompt = "A high-definition image of a beautiful beach"
    output_path = "beach_image"
    generate_image(prompt, output_path)

if __name__ == "__main__":
    main()
