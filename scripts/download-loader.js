const https = require('https');
const fs = require('fs');
const path = require('path');

const files = [
  'DTSLoader.js',
  'DTSParser.js',
  'DTS.js'
];

const baseUrl = 'https://raw.githubusercontent.com/exogen/three-dts-loader/main/src/';
const targetDir = path.join(__dirname, '../src/three-dts-loader');

if (!fs.existsSync(targetDir)) {
  fs.mkdirSync(targetDir, { recursive: true });
}

function download(file) {
  return new Promise((resolve, reject) => {
    const url = baseUrl + file;
    console.log(`Downloading ${url}...`);
    https.get(url, (res) => {
      if (res.statusCode !== 200) {
        reject(new Error(`Failed to download ${file}: Status ${res.statusCode}`));
        return;
      }
      const fileStream = fs.createWriteStream(path.join(targetDir, file));
      res.pipe(fileStream);
      fileStream.on('finish', () => {
        fileStream.close();
        console.log(`Saved ${file}`);
        resolve();
      });
    }).on('error', (err) => {
      reject(err);
    });
  });
}

async function main() {
  try {
    for (const file of files) {
      await download(file);
    }
    console.log('All files downloaded successfully!');
  } catch (err) {
    console.error('Download failed:', err);
    process.exit(1);
  }
}

main();
