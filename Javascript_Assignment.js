    // 1
    let salaries = {John: 100, Ann: 160, Pete:130};
    let sum = 0;
    for(const name in salaries){
    sum+= salaries[name];
    }
    console.log(sum);

    //2
    function multiplyNumeric(obj){
    for(const key in obj){
        if(typeof obj[key]==='number'){
            obj[key]*=2;
        }
     }
    }

    let menu = {width: 200, height: 300, title: "My menu"};
    multiplyNumeric(menu);
    console.log(menu);

    //3
    function checkEmailId(str){
        const re = /^[^\s@]+@[^\s@.]+\.[^\s.]+$/i;
        return re.test(str);
    }

    console.log(checkEmailId("user@example.com"));
    console.log(checkEmailId("user@.com"));

    //4
    function truncate(str, maxlength) {
        if(maxlength<=0) return "";
        if(str.length <= maxlength) return str;
        if(maxlength ===1) return "..."
        const slicelen = maxlength - 1;
        return str.slice(0, slicelen) + "...";
    }

    console.log(truncate("What I'd like to tell on this topic is:", 20));
    console.log(truncate("Hi everyone!", 20));  

    //5
    let styles = ["James", "Brennie"];
    console.log(styles.join(", "));
    styles.push("Robert");
    console.log(styles.join(", "));
    const mid = Math.floor(styles.length / 2);   
    styles[mid] = "Calvin";
    console.log(styles.join(", "));
    styles.shift();
    console.log(styles.join(", "));                   
    styles.unshift("Rose", "Regal");
    console.log(styles.join(", "));                    