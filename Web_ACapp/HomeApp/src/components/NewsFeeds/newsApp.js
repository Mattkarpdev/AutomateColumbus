// import { existsSync, writeFileSync } from "fs";
// import Parser from "rss-parser";
// (async function main() {
//   const parser = new Parser();

//   const feed = await parser.parseURL("https://www.cnet.com/rss/smart-home/");

//   let items = [];
//   const fileName = `${feed.title
//     .replace(/\s+/g, "-")
//     .replace(/[/\\?%*:|"<>]/g, "")
//     .toLowerCase()}.json`;
//   if (existsSync(fileName)) {
//     items = require(fileName);
//   }
//   await Promise.all(
//     feed.items.map(async (currentItem) => {
//       if (items.filter((item) => item === currentItem).length <= 1) {
//         items.push(currentItem);
//       }
//     }),
//   );
//   writeFileSync(components / NewsFeeds / cnetRss.json, JSON.stringify(items));
// })();
