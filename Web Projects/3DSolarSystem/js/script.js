window.onload = function(){



    $( "#slider" ).slider({
      min: 2300,
      max: 10000,
      value: 2300,
      animate: true,
      slide: function( event, ui ) {
     	console.log(ui.value);
	    scene.remove(sun);
        sunCreat(ui.value);
        scene.add(sun);
      }     
    });   
   
	var width = window.innerWidth;
	var height = window.innerHeight;
	var canvas = document.getElementById('canvas');



	canvas.setAttribute('width',width);
	canvas.setAttribute('height',height);

	var renderer = new THREE.WebGLRenderer({canvas: canvas});

	renderer.setClearColor(0x000000);

	var scene = new THREE.Scene();

	var camera = new THREE.PerspectiveCamera(45, width/height, 0.1,500000);

	//camera.position.set(0,0,1000);

	//var ligth = new THREE.AmbientLight(0x222222);

	var ligth = new THREE.PointLight(0xffffff,1.4,100000);//Цвет,интенсивность,дальность
	ligth.position.set(0,0,0);
	ligth.castShadow = true;
	ligth.shadow.mapSize.height = 2048;
	ligth.shadow.mapSize.width = 2048;

	scene.add(ligth);


		camera.position.z = 33000;
		camera.rotation.z = Math.PI/20;
		camera.position.x = 33000;
		camera.position.y = -12000;

	//Stars

	var starsGeometry = new THREE.Geometry();

	var starsMaterial = new THREE.ParticleBasicMaterial({color:0xbbbbbb,opacity:0.1,size:1,
		sizeAttenuation:false
	});

	var stars;

	for (var i = 0 ; i <50000; i++)
	{
		var vertex = new THREE.Vector3();
		vertex.x = Math.random()*2-1;
		vertex.y = Math.random()*2-1;
		vertex.z = Math.random()*2-1;
		vertex.multiplyScalar(40000);
		starsGeometry.vertices.push(vertex);
	}

	stars = new THREE.ParticleSystem(starsGeometry,starsMaterial);
	stars.scale.set(50,50,50);
	scene.add(stars);

	/////////////////////////////////////////////////////////// Stars

	var SunSize = 2300;
	var sun;
	var ring;
	//SUN
	function sunCreat(SunSize) {

	var sun_geometry = new THREE.SphereGeometry(SunSize,40,40);

	var texture = THREE.ImageUtils.loadTexture('sunmap.png');

	texture.anisotropy = 8;

	var sun_material = new THREE.MeshPhongMaterial({map: texture, emissive: 0xffffff});

	//var sun_material = new THREE.MeshNormalMaterial({map: texture});

	sun = new THREE.Mesh(sun_geometry,sun_material);

	var ring_saturn_geom = new THREE.Geometry();
	var ring_saturn_mat = new THREE.ParticleBasicMaterial({color:0x002200,opacity:0.5,size:1,
		sizeAttenuation:false});

	for(var i = 0;i<20000;i++)
	{
		var vertex = new THREE.Vector3();
		vertex.x = Math.sin(Math.PI/180*i)*(SunSize+10000-i/80);
		vertex.y = Math.random()*20;
		vertex.z = Math.cos(Math.PI/180*i)*(SunSize+10000-i/80)
		ring_saturn_geom.vertices.push(vertex);
	}

    ring = new THREE.ParticleSystem(ring_saturn_geom,ring_saturn_mat);

	ring.castShadow = true;

	scene.add(ring);

	}
	
	
	sunCreat(SunSize);
	scene.add(sun);



	///////////////////////////////////////////////////// Sun

	//Merkuri

	var merkuri;

	var merkuri_geometry = new THREE.SphereGeometry(50,10,10);

	var merkuri_texture = THREE.ImageUtils.loadTexture('mercurymap.jpg');

	merkuri_texture.anisotropy = 8;

	var merkuri_material = new THREE.MeshPhongMaterial({map: merkuri_texture, emissive: 0xffffff});

	merkuri = new THREE.Mesh(merkuri_geometry,merkuri_material);

	merkuri.castShadow = true;

	scene.add(merkuri);

	//////////////////////////////////////////////////// Merkuri

	//venera

	var venera;

	var venera_geometry = new THREE.SphereGeometry(90,20,20);

	var venera_texture = THREE.ImageUtils.loadTexture('venusmap.jpg');

	venera_texture.anisotropy = 8;

	var venera_material = new THREE.MeshPhongMaterial({map: venera_texture, emissive: 0xffffff});

	venera = new THREE.Mesh(venera_geometry,venera_material);

	venera.castShadow = true;

	scene.add(venera);

	//////////////////////////////////////////////////// venera

	//Earth
	var earth;

	var earth_geometry = new THREE.SphereGeometry(100,20,20);

	var texture_earth = THREE.ImageUtils.loadTexture('earthmap1k.jpg');

	texture_earth.anisotropy = 8;

	var earth_material = new THREE.MeshPhongMaterial({map: texture_earth, emissive: 0xffffff});

	earth = new THREE.Mesh(earth_geometry,earth_material);

	earth.castShadow = true;

	scene.add(earth);

	var earth_geom_orbit = new THREE.Geometry();
	var earth_mat_orbit  = new THREE.ParticleBasicMaterial({color:0x000022,opacity:0.8,size:1,
		sizeAttenuation:false});

	for(var i = 0;i<20000;i++)
	{
		var vertex = new THREE.Vector3();
		vertex.x = Math.sin(Math.PI/180*i)*9500;
		vertex.z = Math.cos(Math.PI/180*i)*9500;
		earth_geom_orbit.vertices.push(vertex);
	}

    var earth_orbit = new THREE.ParticleSystem(earth_geom_orbit,earth_mat_orbit);

	earth_orbit.castShadow = true;

	scene.add(earth_orbit);
	//////////////////////////////////////////////////// Earth

	// luna
	var luna;

	var luna_geometry = new THREE.SphereGeometry(10,10,10);

	var texture_luna = THREE.ImageUtils.loadTexture('moonmap1k.jpg');

	texture_luna.anisotropy = 8;

	var luna_material = new THREE.MeshPhongMaterial({map: texture_luna, emissive: 0xffffff});


	luna = new THREE.Mesh(luna_geometry,luna_material);

	luna.castShadow = true;

	scene.add(luna);
	//////////////////////////////////////////////////// luna

	//mars

	var mars;

	var mars_geometry = new THREE.SphereGeometry(70,20,20);

	var mars_texture = THREE.ImageUtils.loadTexture('mars_1k_color.jpg');

	mars_texture.anisotropy = 8;

	var mars_material = new THREE.MeshPhongMaterial({map: mars_texture, emissive: 0xffffff});

	mars = new THREE.Mesh(mars_geometry,mars_material);

	mars.castShadow = true;

	scene.add(mars);

	//////////////////////////////////////////////////// mars

	//upiter

	var upiter;

	var upiter_geometry = new THREE.SphereGeometry(1200,40,40);

	var upiter_texture = THREE.ImageUtils.loadTexture('jupitermap.jpg');

	upiter_texture.anisotropy = 8;

	var upiter_material = new THREE.MeshPhongMaterial({map: upiter_texture});

	upiter = new THREE.Mesh(upiter_geometry,upiter_material);

	upiter.castShadow = true;

	scene.add(upiter);

	//////////////////////////////////////////////////// upiter

	//saturn

	var saturn;

	var saturn_geometry = new THREE.SphereGeometry(1100,40,40);

	var saturn_texture = THREE.ImageUtils.loadTexture('saturnmap.jpg');

	saturn_texture.anisotropy = 8;

	var saturn_material = new THREE.MeshPhongMaterial({map: saturn_texture});

	saturn = new THREE.Mesh(saturn_geometry,saturn_material);

	saturn.castShadow = true;

	scene.add(saturn);

	/*var ring_saturn_geom = new THREE.Geometry();
	var ring_saturn_mat = new THREE.ParticleBasicMaterial({color:0x002200,opacity:0.3,size:1,
		sizeAttenuation:false});

	for(var i = 0;i<20000;i++)
	{
		var vertex = new THREE.Vector3();
		vertex.x = Math.sin(Math.PI/180*i)*(2200-i/80);
		vertex.y = Math.random()*20;
		vertex.z = Math.cos(Math.PI/180*i)*(2200-i/80)
		ring_saturn_geom.vertices.push(vertex);
	}

	var ring = new THREE.ParticleSystem(ring_saturn_geom,ring_saturn_mat);

	ring.castShadow = true;

	scene.add(ring);*/

	//////////////////////////////////////////////////// saturn

	//yran

	var yran;

	var yran_geometry = new THREE.SphereGeometry(800,30,30);

	var yran_texture = THREE.ImageUtils.loadTexture('uranusmap.jpg');

	yran_texture.anisotropy = 8;

	var yran_material = new THREE.MeshPhongMaterial({map: yran_texture, emissive: 0xffffff});

	yran = new THREE.Mesh(yran_geometry,yran_material);

	yran.castShadow = true;

	scene.add(yran);

	//////////////////////////////////////////////////// yran

	//neptun

	var neptun;

	var neptun_geometry = new THREE.SphereGeometry(800,30,30);

	var neptun_texture = THREE.ImageUtils.loadTexture('neptunemap.jpg');

	neptun_texture.anisotropy = 8;

	var neptun_material = new THREE.MeshPhongMaterial({map: neptun_texture, emissive: 0xffffff});

	neptun = new THREE.Mesh(neptun_geometry,neptun_material);

	neptun.castShadow = true;

	scene.add(neptun);

	//////////////////////////////////////////////////// neptun

	//pluton

	var pluton;

	var pluton_geometry = new THREE.SphereGeometry(50,10,10);

	var pluton_texture = THREE.ImageUtils.loadTexture('plutomap1k.jpg');

	pluton_texture.anisotropy = 8;

	var pluton_material = new THREE.MeshPhongMaterial({map: pluton_texture, emissive: 0xffffff});

	pluton = new THREE.Mesh(pluton_geometry,pluton_material);

	pluton.castShadow = true;

	scene.add(pluton);

	//////////////////////////////////////////////////// pluton

	//GreenZone
	
	//////////////////////////////////////////////////// GreenZone

	//camera
		var y = 0;
		var x = 0;
		var z = 32000;

		document.addEventListener('mousemove',function(event){
			y = parseInt(event.offsetY);
			x = parseInt(event.offsetX);
		});
		
		// Функция для добавления обработчика событий
  function addHandler(object, event, handler) {
    if (object.addEventListener) {
      object.addEventListener(event, handler, false);
    }
    else if (object.attachEvent) {
      object.attachEvent('on' + event, handler);
    }
    else alert("Обработчик не поддерживается");
  }
  // Добавляем обработчики для разных браузеров
  addHandler(window, 'DOMMouseScroll', wheel);
  addHandler(window, 'mousewheel', wheel);
  addHandler(document, 'mousewheel', wheel);
  // Функция, обрабатывающая событие
  function wheel(event) {
    var delta; // Направление колёсика мыши
    event = event || window.event;
    // Opera и IE работают со свойством wheelDelta
    if (event.wheelDelta) { // В Opera и IE
      delta = event.wheelDelta / 120;
      // В Опере значение wheelDelta такое же, но с противоположным знаком
      if (window.opera) delta = -delta; // Дополнительно для Opera
    }
    else if (event.detail) { // Для Gecko
      delta = -event.detail / 3;
    }
    // Запрещаем обработку события браузером по умолчанию
    if (event.preventDefault) event.preventDefault();
    event.returnValue = false;
   	// Функция для добавления обработчика событий
  function addHandler(object, event, handler) {
    if (object.addEventListener) {
      object.addEventListener(event, handler, false);
    }
    else if (object.attachEvent) {
      object.attachEvent('on' + event, handler);
    }
    else alert("Обработчик не поддерживается");
  }
  // Добавляем обработчики для разных браузеров
  addHandler(window, 'DOMMouseScroll', wheel);
  addHandler(window, 'mousewheel', wheel);
  addHandler(document, 'mousewheel', wheel);
  // Функция, обрабатывающая событие
  function wheel(event) {
    var delta; // Направление колёсика мыши
    event = event || window.event;
    // Opera и IE работают со свойством wheelDelta
    if (event.wheelDelta) { // В Opera и IE
      delta = event.wheelDelta ;
      // В Опере значение wheelDelta такое же, но с противоположным знаком
      if (window.opera) delta = -delta; // Дополнительно для Opera
    }
    else if (event.detail) { // Для Gecko
      delta = -event.detail ;
    }
    // Запрещаем обработку события браузером по умолчанию
    if (event.preventDefault) event.preventDefault();
    event.returnValue = true;
    	if(delta>0)
    	{
    		z+=300;
    	}else{z-=300} // Выводим направление колёсика мыши
  } // Выводим направление колёсика мыши
  }
	//////////////////////////////////////////////////// camera

	var t=0;


 	function loop(){


		sun.rotation.y += Math.PI / 4500;
		if(!info){
		
		merkuri.position.x = Math.sin(t*1)*4000;
		merkuri.position.z = Math.cos(t*1)*4000;

		
		venera.position.x = Math.sin(t*0.4)*6000;
		venera.position.z = Math.cos(t*0.4)*6000;

		
		earth.position.x = Math.sin(t*0.3)*9500;
		earth.position.z = Math.cos(t*0.3)*9500;

		
		mars.position.x = Math.sin(t*0.35)*11500;
		mars.position.z = Math.cos(t*0.35)*11500;

		
		upiter.position.x = Math.sin(t*0.03)*16500;
		upiter.position.z = Math.cos(t*0.03)*16500;

		
		saturn.position.x = Math.sin(t*0.027)*20500;
		saturn.position.z = Math.cos(t*0.027)*20500;

		/*ring.position.x = saturn.position.x;
		ring.position.z = saturn.position.z;
		ring.rotation.y -= 0.0001;*/

		
		yran.position.x = Math.sin(t*0.1)*23500;
		yran.position.z = Math.cos(t*0.1)*23500;

		
		neptun.position.x = Math.sin(t*0.08)*25500;
		neptun.position.z = Math.cos(t*0.08)*25500;

		
		pluton.position.x = Math.sin(t*0.6)*28500;
		pluton.position.z = Math.cos(t*0.6)*28500;

		camera.position.y= -12000+y*100;
		camera.position.x= 32000+x*40;
		camera.lookAt(sun.position);

		t+=Math.PI/180*2;
		}
		else{
		
		}

		luna.position.x = earth.position.x + Math.sin(t*2)*120;
		luna.position.z = earth.position.z + Math.cos(t*2)*120;
		merkuri.rotation.y += Math.PI / 500;
		venera.rotation.y += Math.PI / 1200;
		earth.rotation.y += Math.PI / 1000;
		luna.rotation.y += Math.PI / 500;
		mars.rotation.y += Math.PI / 1100;
		upiter.rotation.y += Math.PI / 3000;
		saturn.rotation.y += Math.PI / 2500;
		yran.rotation.y += Math.PI / 1000;
		neptun.rotation.y += Math.PI / 2500;
		pluton.rotation.y += Math.PI / 2500;

		renderer.render(scene,camera);
		requestAnimationFrame(function(){loop()});//Когда браузер готов , вызываеться функция 
	}

	loop();

}