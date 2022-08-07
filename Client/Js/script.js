// import 'Konva' from Konva


// function getPoint(url) {
//     return  fetch(url).then(response => {
//         return response.json()
//     })
// }
async function getPoint(url){
    let key
    let response = await fetch(url).then()
    let content = await response.json()
    let data = []
    for(key in content){
           console.log(content[key])
            data.push(content[key])
    }
    console.log(data[0].comment)
}


const URL = 'https://localhost:7232/api/Point/View'

getPoint(URL)

let width = window.innerWidth;
let height = window.innerHeight;

let stage = new Konva.Stage({
    container: 'container',
    width: width,
    height: height,
});

let sto = new Konva.Rect({
    x: 20,
    y: 20,
    width: 100,
    height: 50,
    fill: 'green',
    stroke: 'black',
    strokeWidth: 4,
})
let layer = new Konva.Layer()

layer.add(sto)

stage.add(layer);


