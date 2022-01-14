let image = document.querySelector("#main_image");
let a = ["pizza.jpg", "fa9.jpg","cake1.jpg","bread1.jpg" ];
let i = 0;

const change = setInterval(()=> {
    
    if(i === 2)
        i = 0
    else
        i++
    image.setAttribute("src", a[i]);
}, 2000);