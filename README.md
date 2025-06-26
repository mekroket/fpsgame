# 🎯 FPS Game

Unity ile geliştirilen bu birinci şahıs nişancı (FPS) oyunu; oyuncuya silah kullanma, düşmanları yenme ve haritada özgürce dolaşma imkânı tanır. Proje, temel FPS mekaniklerini öğrenmek, geliştirmek ve özelleştirmek isteyenler için sade ve genişletilebilir bir altyapı sunar.

---

## 🕹️ Özellikler

- 🔫 Silah sistemi (ateş etme, şarjör, mermi yönetimi)
- 🧍‍♂️ FPS karakter kontrolü (yürüme, zıplama, eğilme)
- 🎯 Düşman AI (takip, saldırı)
- 🗺️ Sahne & seviye tasarımı
- 🎚️ UI: Mermi sayacı, sağlık göstergesi
- 🔊 Ses efektleri (silah sesi, çevresel sesler)
- ☀️ Basit aydınlatma ve çevre öğeleri

---

## 🛠️ Kullanılan Teknolojiler

- Unity 2022.x veya üzeri
- C# (MonoBehaviour)
- Unity Input System
- Rigidbody / Character Controller
- Visual Studio Code / Rider

---

## 📁 Proje Yapısı

Assets/ → Oyun içeriği (Prefab, Script, Sahne)
Scripts/ → FPS kontrol, silah, düşman kodları
Scenes/ → Oyun sahneleri
UI/ → Arayüz öğeleri
ProjectSettings/ → Unity proje ayarları
Packages/ → Kullanılan Unity paketleri


---

## 🚀 Kurulum

Projeyi bilgisayarına klonlayıp Unity ile çalışmaya başlamak için:

```bash
git clone https://github.com/mekroket/fpsgame.git
```


🧪 Geliştirici Notları
FPSController.cs dosyası, karakterin hareketini yönetir.

Weapon.cs silah özelliklerini (hasar, ateş hızı vs.) içerir.

EnemyAI.cs basit takip sistemiyle düşmanı hareket ettirir.
