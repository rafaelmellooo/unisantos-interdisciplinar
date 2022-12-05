import { useState } from "react";
import { useSpring, animated } from "react-spring";
import MenuIcon from '@mui/icons-material/Menu';

export const SideMenu = () => {
    const [opened, setOpened] = useState(false);

    const handleMenuToggle = () => {
        setOpened(opened => !opened);
    }

    const { left } = useSpring({
        from: { left: "-100%" },
        left: opened ? "0" : "-100%"
    });

    return (
        <>
            <div className="menu-button" id="menuButton" onClick={(handleMenuToggle)}>
                <MenuIcon />
            </div>

            <animated.div style={{ left: left }} className="sideMenu">
                <div className="items-container">
                    Menu aaaaaaaaaa
                </div>

                <div className="close-conainer" onClick={handleMenuToggle} />
            </animated.div>
        </>
    );
};